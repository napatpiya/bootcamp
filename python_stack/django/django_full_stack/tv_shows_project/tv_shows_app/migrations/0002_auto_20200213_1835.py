# Generated by Django 2.2 on 2020-02-13 18:35

from django.db import migrations


class Migration(migrations.Migration):

    dependencies = [
        ('tv_shows_app', '0001_initial'),
    ]

    operations = [
        migrations.RenameField(
            model_name='tvshows',
            old_name='Description',
            new_name='description',
        ),
        migrations.RenameField(
            model_name='tvshows',
            old_name='ReleaseDate',
            new_name='releasedate',
        ),
        migrations.RenameField(
            model_name='tvshows',
            old_name='Title',
            new_name='title',
        ),
    ]
