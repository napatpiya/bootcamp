from django.shortcuts import render, redirect, HttpResponse
from the_wall_app.models import Users, Messages, Comments
import bcrypt
from django.contrib import messages

# Create your views here.
def index(request):
    return render(request, "login.html")

def login(request):
    print(request.POST)
    request.session['check'] = "logged_in"
    request.session['lemail'] = request.POST['l_email']
    errors = Users.objects.loginvalidator(request.POST, request)
    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value)
        return redirect("/")
    request.session.clear()
    loginuser = Users.objects.get(email=request.POST['l_email'])
    request.session['login_id'] = loginuser.id
    return redirect("/wall")

def register(request):
    print(request.POST)
    request.session['check'] = "registed"
    request.session['fname'] = request.POST['r_fname']
    request.session['lname'] = request.POST['r_lname']
    request.session['email'] = request.POST['r_email']
    errors = Users.objects.registervalidator(request.POST, request)
    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value)
        return redirect("/")
    request.session.clear()
    password = request.POST['r_password']
    pw_hash = bcrypt.hashpw(password.encode(), bcrypt.gensalt()).decode()
    newuser = Users.objects.create(first_name=request.POST['r_fname'], last_name=request.POST['r_lname'], email=request.POST['r_email'], password=pw_hash)
    request.session['login_id'] = newuser.id
    print(request.session['login_id'])
    return redirect("/")

def wall(request):
    context = {
        'loginuser': Users.objects.get(id=request.session['login_id'])
    }
    return render(request, "wall.html", context)

def logout(request):
    request.session.clear()
    return redirect("/")
