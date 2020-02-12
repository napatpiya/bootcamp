from django.urls import path
from . import views

urlpatterns = [
    path('', views.index),
    path('addbook', views.addbook),
    path('authors', views.author),
    path('addauthor', views.addauthor),
    path('books/<int:id>', views.bookindex),
    path('authors/<int:id>', views.authorindex),
    path('addmoreauthor', views.addmoreauthor),
    path('addmorebook', views.addmorebook),
]