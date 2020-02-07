from django.urls import path
from . import views

urlpatterns = [
    path('', views.index),
    path('process_money', views.process),
    path('reset', views.reset)
    #path('admin/', admin.site.urls),
]