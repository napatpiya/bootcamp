from django.urls import path
from . import views

urlpatterns = [
    path('', views.index),
    path('login', views.login),
    path('register', views.register),
    path('wall', views.wall),
    path('createmessage', views.createmessage),
    path('createcomment', views.createcomment),
    path('delete/<int:commid>', views.delete),
    path('logout', views.logout),
]