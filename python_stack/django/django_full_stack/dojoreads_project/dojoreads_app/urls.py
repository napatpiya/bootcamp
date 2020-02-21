from django.urls import path
from . import views

urlpatterns = [
    path('', views.index),
    path('login', views.login),
    path('register', views.register),
    path('books', views.books),
    path('addbook', views.addbook),
    path('savebook', views.savebook),
    path('bookinfo/<int:bookid>', views.bookinfo),
    path('addreview/<int:bookid>', views.addreview),
    path('users/<int:userid>', views.userinfo),
    path('delete/<int:reviewid>/<int:bookid>', views.delete),
    path('logout', views.logout),
]