from django.shortcuts import render, redirect
from dojoreads_app.models import *
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
    return redirect("/books")

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
    newuser = Users.objects.create(first_name=request.POST['r_fname'], alias=request.POST['r_lname'], email=request.POST['r_email'], password=pw_hash)
    request.session['login_id'] = newuser.id
    print(request.session['login_id'])
    return redirect("/")

def books(request):
    context = {
        'allbooks': Books.objects.all(),
        'allauthors': Authors.objects.all(),
        'lastreview': Reviews.objects.all().order_by('-created_at')[:3],
        'user': Users.objects.get(id=request.session['login_id']),
        'bookreview': Books.objects.filter(isreview=True),
    }
    return render(request, "books.html", context)

def addbook(request):
    context = {
        'allauthors': Authors.objects.all(),
    }
    return render(request, "addbook.html", context)

def savebook(request):
    print(request.POST)
    request.session['booktitle'] = request.POST['booktitle']
    request.session['bookauthor2'] = request.POST['bookauthor2']
    request.session['bookreview'] = request.POST['bookreview']
    errors = Users.objects.savebookvalidator(request.POST, request)
    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value)
        return redirect("/addbook")
    if request.POST['bookauthor2'] != "":
        if len(Authors.objects.filter(name=request.POST['bookauthor2'])) > 0:
            bookauthor = Authors.objects.get(name=request.POST['bookauthor2'])
        else:
            bookauthor = Authors.objects.create(name=request.POST['bookauthor2'])
    else:
        bookauthor = Authors.objects.get(name=request.POST['bookauthor1'])
    
    # if request.session['bookreview'] != "":
    book = Books.objects.create(title=request.POST['booktitle'], isreview=True, user=Users.objects.get(id=request.session['login_id']), author=bookauthor)
    Reviews.objects.create(review=request.POST['bookreview'], rating=request.POST['bookrating'], user=Users.objects.get(id=request.session['login_id']), book=book)
    # else:
    #     book = Books.objects.create(title=request.POST['booktitle'], isreview=False, user=Users.objects.get(id=request.session['login_id']), author=bookauthor)

    request.session['booktitle'] = ""
    request.session['bookauthor2'] = ""
    request.session['bookreview'] = ""
    return redirect("/books")

def bookinfo(request, bookid):
    context = {
        'book': Books.objects.get(id=bookid),
        'allreviews': Reviews.objects.filter(book=bookid),
    }
    return render(request, "bookinfo.html", context)

def addreview(request, bookid):
    print(request.POST)
    request.session['bookreview'] = request.POST['bookreview']
    request.session['bookrating'] = request.POST['bookrating']
    errors = Users.objects.savereviewvalidator(request.POST, request)
    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value)
        return redirect(f"/bookinfo/{bookid}")
    Reviews.objects.create(review=request.POST['bookreview'], rating=request.POST['bookrating'], user=Users.objects.get(id=request.session['login_id']), book=Books.objects.get(id=bookid))
    book = Books.objects.get(id=bookid)
    book.isreview = True
    book.save()
    request.session['bookreview'] = ""
    request.session['bookrating'] = ""
    return redirect(f"/bookinfo/{bookid}")

def userinfo(request, userid):
    reviews = Reviews.objects.filter(user=Users.objects.get(id=userid))
    request.session['countreview'] = 0
    for view in reviews:
        request.session['countreview'] += 1
    context = {
        'user': Users.objects.get(id=userid),
        'countreview': request.session['countreview'],
        'books': Reviews.objects.filter(user=Users.objects.get(id=userid)),
    }
    return render(request, "userinfo.html", context)

def delete(request, reviewid, bookid):
    review = Reviews.objects.get(id=reviewid)
    review.delete()
    # if len(Reviews.objects.filter(book=Books.objects.get(id=bookid))) < 0:
    #     book = Books.objects.get(id=bookid)
    #     book.isreview = False
    #     book.save()
    return redirect(f"/bookinfo/{bookid}")

def logout(request):
    request.session.clear()
    return redirect("/")