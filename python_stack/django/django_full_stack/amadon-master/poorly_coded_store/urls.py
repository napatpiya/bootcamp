from django.urls import path
from . import views

urlpatterns = [
    path('', views.index),
    path('checkout/', views.checkout),
    path('calc', views.calc),
    path('reset', views.reset)
]
