# Generated by Django 2.2 on 2020-02-13 18:41

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('tv_shows_app', '0002_auto_20200213_1835'),
    ]

    operations = [
        migrations.AlterField(
            model_name='tvshows',
            name='releasedate',
            field=models.DateField(null=True),
        ),
    ]