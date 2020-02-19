from django.db import models
import bcrypt

# Create your models here.
class ValiManager(models.Manager):
    def registervalidator(self, postData, request):
        errors = {}
        if len(postData['r_fname']) < 2:
            errors["r_fname"] = "First name should be at least 2 characters"
            request.session['fname'] = ""
        if len(postData['r_lname']) < 2:
            errors["r_lname"] = "Last name should be at least 2 characters"
            request.session['lname'] = ""
        if len(postData['r_email']) < 1:
            errors["r_email"] = "Email address should be valid"
            request.session['email'] = ""
        for name in Users.objects.all():
            if postData['r_email'] == name.email:
                errors["r_emailcheck"] = "Existing email address in the database"
                request.session['email'] = ""
        if len(postData['r_password']) < 8:
            errors['r_pass'] = "Password should be at least 8 characters"
        if postData['r_password'] != postData['r_passwordcheck']:
            errors['r_passcheck'] = "Password does not match"         
        return errors
            
    def loginvalidator(self, postData, request):
        errors = {}
        if len(postData['l_email']) < 1:
            errors["l_email"] = "Please enter the email"
            request.session['lemail'] = ""
        else:
            user = Users.objects.filter(email=postData['l_email'])
            if user:
                logged_user = user[0]
                print(logged_user)
                if bcrypt.checkpw(request.POST['l_password'].encode(), logged_user.password.encode()):
                    request.session['userid'] = logged_user.id
                else:
                    errors['lpass'] = "Incorrect password, please try again."
            else:
                request.session['lemail'] = ""
                errors['lemail'] = "Your email is not in the database"        
        return errors

    def postvalidator(self, postData, request):
        errors = {}
        if len(postData['post']) < 5:
            errors["post"] = "Post should be at least 5 characters"      
        return errors
    
    def commvalidator(self, postData, request):
        errors = {}
        if len(postData['comment']) < 5:
            errors["comment"] = "Comment should be at least 5 characters"      
        return errors

class Users(models.Model):
    first_name = models.CharField(max_length=45)
    last_name = models.CharField(max_length=45)
    email = models.CharField(max_length=45)
    password = models.CharField(max_length=20)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = ValiManager()

class Messages(models.Model):
    message = models.TextField()
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    user = models.ForeignKey(Users, related_name="user_message", on_delete=models.CASCADE)

class Comments(models.Model):
    comment = models.TextField()
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    user = models.ForeignKey(Users, related_name="user_com", on_delete=models.CASCADE)
    message = models.ForeignKey(Messages, related_name="message_com", on_delete=models.CASCADE)