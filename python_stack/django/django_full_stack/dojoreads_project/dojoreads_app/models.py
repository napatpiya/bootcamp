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
            errors["r_lname"] = "Alias name should be at least 2 characters"
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

    def savebookvalidator(self, postData, request):
        errors = {}
        if len(Books.objects.filter(title=postData['booktitle'])) > 0:
            errors['titlecheck'] = "The title found in database."
            request.session['booktitle'] = ""
            request.session['bookauthor1'] = ""
            request.session['bookauthor2'] = ""
            request.session['bookreview'] = ""
        else:
            if len(postData['booktitle']) < 3:
                errors['title'] = "The title should be at least 3 character."
                request.session['booktitle'] = ""
            if postData['bookauthor1'] == "0" and postData['bookauthor2'] == "":
                errors['autor'] = "Please select the author."
            elif postData['bookauthor1'] != "0" and postData['bookauthor2'] != "":
                errors['autor'] = "Please select just one author."
                request.session['bookauthor2'] = ""
            if len(postData['bookreview']) < 1:
                errors['review'] = "Please review this book."
                request.session['bookreview'] = ""
            if postData['bookrating'] == "nostar":
                errors['rating'] = "Please give the rating"
            # if len(postData['bookreview']) > 0 or postData['bookrating'] != "nostar":
            #     if len(postData['bookreview']) > 0 and postData['bookrating'] == "nostar":
            #         errors['review'] = "Please rating."
            #     elif len(postData['bookreview']) < 1 and postData['bookrating'] != "nostar":
            #         errors['reviewrating'] = "Please review the book."
        return errors
    
    def savereviewvalidator(self, postData, request):
        errors = {}
        if len(postData['bookreview']) < 1:
            errors['review'] = "Please review this book."
            request.session['bookreview'] = ""
        if postData['bookrating'] == "nostar":
            errors['rating'] = "Please give the rating"
        return errors

    # def postvalidator(self, postData, request):
    #     errors = {}
    #     if len(postData['post']) < 5:
    #         errors["post"] = "Post should be at least 5 characters"      
    #     return errors
    
    # def commvalidator(self, postData, request):
    #     errors = {}
    #     if len(postData['comment']) < 5:
    #         errors["comment"] = "Comment should be at least 5 characters"      
    #     return errors

class Users(models.Model):
    first_name = models.CharField(max_length=255)
    alias = models.CharField(max_length=255)
    email = models.CharField(max_length=255)
    password = models.CharField(max_length=255)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = ValiManager()

class Authors(models.Model):
    name = models.CharField(max_length=255)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

class Books(models.Model):
    title = models.CharField(max_length=255)
    isreview = models.BooleanField(default=False)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    user = models.ForeignKey(Users, related_name="user_book", on_delete=models.CASCADE)
    author = models.ForeignKey(Authors, related_name="author_book", on_delete=models.CASCADE)

class Reviews(models.Model):
    review = models.TextField()
    rating = models.CharField(max_length=5)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    user = models.ForeignKey(Users, related_name="user_review", on_delete=models.CASCADE)
    book = models.ForeignKey(Books, related_name="book_review", on_delete=models.CASCADE)
