from django.db import models
import datetime
import bcrypt

# Create your models here.
class ValiManager(models.Manager):
    def validator(self, postData, request):
        if request.session['check'] == 'registered':
            errors = {}
            present = datetime.date.today()
            birthdate = datetime.datetime.strptime(postData['r_birthdate'], "%Y-%m-%d").date()
            if len(postData['r_fname']) < 2 or len(postData['r_lname']) < 2:
                errors["r_fname"] = "First name & last name should be at least 2 characters"
                request.session['fname'] = ""
            if len(postData['r_email']) < 1:
                errors["r_email"] = "Email address should be valid"
                request.session['lname'] = ""
            for name in User.objects.all():
                if postData['r_email'] == name.email:
                    errors["r_emailcheck"] = "Existing email address in the system"
                    request.session['email'] = ""
            if postData['r_birthdate'] == '':
                errors['r_birthdate'] = "Birth date should not be null"
                request.session['birthdate'] = ""
            if birthdate > present:
                errors['r_birthdate'] = "Birth date should be the past"
                request.session['birthdate'] = ""
            age = (present - birthdate).days/365
            if age < 13:
                errors['r_birthdatecheck'] = "User is at least 13 years old"
            if len(postData['r_pass']) < 8:
                errors['r_pass'] = "Password should be at least 8 characters"
                request.session['pass'] = ""
                request.session['passcheck'] = ""
            if postData['r_pass'] != postData['r_passcheck']:
                errors['r_passcheck'] = "Password does not match"
                request.session['pass'] = ""
                request.session['passcheck'] = ""           
            return errors
        else:
            errors = {}
            if len(postData['l_email']) < 1:
                errors["l_email"] = "Please enter the email"
                request.session['lemail'] = ""
            else:
                user = User.objects.filter(email=postData['l_email'])
                if user:
                    logged_user = user[0]
                    print(logged_user)
                    if bcrypt.checkpw(request.POST['l_pass'].encode(), logged_user.password.encode()):
                        request.session['userid'] = logged_user.id
                    else:
                        errors['lpass'] = "Wrong password, please try again."
                else:
                    request.session['lemail'] = ""
                    errors['lemail'] = "Your email is not in the system"        
            return errors

class User(models.Model):
    first_name = models.CharField(max_length=45)
    last_name = models.CharField(max_length=45)
    birth_date = models.DateField(null=True, blank=True)
    email = models.CharField(max_length=45)
    password = models.CharField(max_length=20)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = ValiManager()