from django.db import models
import datetime

# Create your models here.
class ValiManager(models.Manager):
    def validator(self, postData, request):
        errors = {}
        print(datetime.date.today())
        print(postData['reldate'])
        present = datetime.date.today()
        reldate = datetime.datetime.strptime(postData['reldate'], "%Y-%m-%d").date()
        print(reldate > present)
        if len(postData['title']) < 2:
            errors["title"] = "Title name should be at least 2 characters"
        if request.session['check'] == 1:
            errors["title"] = "The title already exist in the database"
        if len(postData['network']) < 3:
            errors["network"] = "Network name should be at least 3 characters"
        if postData['reldate'] == '':
            errors['reldate'] = "Release Date should not be null"
        if reldate > present:
            errors['reldate'] = "Release Date should be the past"
        if len(postData['desc']) != 0 and len(postData['desc']) < 10:
            errors['desc'] = "Description name should be at least 10 characters (Optional)"
        return errors

class TvShows(models.Model):
    title = models.CharField(max_length=45)
    network =  models.CharField(max_length=20)
    releasedate = models.DateField(null=True, blank=True)
    description = models.TextField()
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = ValiManager()
