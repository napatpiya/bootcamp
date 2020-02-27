from django.shortcuts import render, HttpResponse, redirect
from ..courses import views

# Create your views here.
def index(request):
    return render(request, "login.html")

def login(request):
    return redirect("/courses")
