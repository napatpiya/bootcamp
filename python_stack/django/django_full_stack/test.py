import re
import bcrypt

class ValidatorManager(models.Manager):
    def registrationValidator(self, postData, request):
        error = {}

        # Validation name
        if len(postData['r_fname']) < 1:
            errors['fname'] = "Hey! First name is required"
        if len(postData['r_lname']) < 1:
            errors['lname'] = "Hey! Last name is required"

        # Validation date
        if postData['r_datefrom'] >= postData['r_dateto']:
            errors['date'] = "Date from does not over date to"

        # Validation Email
        EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')
        userWithEmail = User.objects.filter(email = postData['r_email'])
        if len(postData['r_email']) < 1:
            errors['emailreq'] = "Email is required"
        elif not EMAIL_REGEX.match(postData['r_email']):
            errors['emailformat'] = "Email is in invalid format"
        elif len(usersWithEmail) > 0:
            errors['emailtaken'] = "Email taken"

        # Validation password
        if len(postData['r_password']) < 8:
            errors['password'] = "Password must be at least 8 characters long"
        elif postData['password'] != postData['passwordcheck']:
            errors['passwordcheck'] = "Password and confirm password must match"
        
        return errors
    
    def loginValidation(self, postData, request):
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
                errors['lemail'] = "Email doesn't exist. Please regiester first."        
        return errors

    objects = ValidatorManager()