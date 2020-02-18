from django.shortcuts import render, HttpResponse, redirect
from login_and_registraton_app.models import User
import bcrypt
from django.contrib import messages

# Create your views here.
def index(request):
    request.session['checkaccess']= "no"
    return render(request, 'index.html')

def register(request):
    print(request.POST)
    request.session['check'] = "registered"
    request.session['fname'] = request.POST["r_fname"]
    request.session['lname'] = request.POST["r_lname"]
    request.session['email'] = request.POST["r_email"]
    request.session['birthdate'] = request.POST["r_birthdate"]
    request.session['pass'] = request.POST["r_pass"]
    request.session['passcheck'] = request.POST["r_passcheck"]
    errors = User.objects.validator(request.POST, request)
    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value)
        return redirect("/")
    password = request.POST['r_pass']
    pw_hash = bcrypt.hashpw(password.encode(), bcrypt.gensalt()).decode()
    newuser = User.objects.create(first_name=request.POST['r_fname'], last_name=request.POST['r_lname'], birth_date=request.POST['r_birthdate'], email=request.POST['r_email'], password=pw_hash)
    request.session['checkaccess']= "yes"
    return redirect("/success")

def login(request):
    print(request.POST)
    request.session['check'] = "logged in"
    request.session['lemail'] = request.POST['l_email']
    errors= User.objects.validator(request.POST, request)
    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value)
        return redirect("/")
    request.session['checkaccess']= "yes"
    return redirect("/success")

def success(request):
    if request.session['checkaccess'] != "yes":
        return redirect('/')
    if request.session['check'] == "logged in":
        context = {
            'user': User.objects.get(id=request.session['userid'])
        }
    else:
        context = {
            'user': User.objects.last()
        }
    return render(request, "success.html", context)

def logout(request):
    request.session['fname'] = ""
    request.session['check'] = ""
    request.session['lname'] = ""
    request.session['email'] = ""
    request.session['birthdate'] = ""
    request.session['pass'] = ""
    request.session['passcheck'] = ""
    request.session['lemail'] = ""
    request.session['checkaccess']= "no"
    return redirect("/")