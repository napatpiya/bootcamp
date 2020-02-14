from django.urls import path
from . import views

urlpatterns = [
    path('', views.index),
    path('shows', views.shows, name='shows'),
    path('shows/new', views.addnew, name='addnew'),
    path('shows/<int:id>', views.showinfo, name='showinfo'),
    path('shows/<int:id>/edit', views.editshow, name='editshow'),
    path('shows/create', views.createshow),
    path('shows/<int:id>/update', views.updateshow, name='updateshow'),
    path('shows/<int:id>/destroy', views.destroyshow, name='destroyshow')
]