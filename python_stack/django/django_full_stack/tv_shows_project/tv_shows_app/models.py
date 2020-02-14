from django.db import models

# Create your models here.
class TvShows(models.Model):
    title = models.CharField(max_length=45)
    network =  models.CharField(max_length=20)
    releasedate = models.DateField(null=True, blank=True)
    description = models.TextField()
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
