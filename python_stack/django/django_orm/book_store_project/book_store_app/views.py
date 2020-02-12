from django.shortcuts import render, HttpResponse, redirect
from book_store_app.models import Books, Authors

# Create your views here.
def index(request):
    context = {
        "book": Books.objects.all(),
    }
    return render(request, 'index.html', context)

def addbook(request):
    newtitle = request.POST['title']
    newdesc = request.POST['desc']
    print(newtitle)
    print(newdesc)
    Books.objects.create(title=newtitle, desc=newdesc)
    return redirect('/')

def author(request):
    context = {
        "author": Authors.objects.all(),
    }
    return render(request, 'authors.html', context)

def addauthor(request):
    newfname = request.POST['fname']
    newlname = request.POST['lname']
    newnote = request.POST['notes']
    print(newfname)
    print(newlname)
    print(newnote)
    Authors.objects.create(first_name=newfname, last_name=newlname, notes=newnote)
    return redirect('/authors')


def bookindex(request, id):
    context = {
        'book': Books.objects.get(id=id),
        'author': Authors.objects.filter(book=id),
        'another': Authors.objects.exclude(book=id)
    }
    request.session['bookind'] = id
    return render(request, 'bookindex.html', context)

def authorindex(request, id):
    context = {
        'author': Authors.objects.get(id=id),
        'book': Books.objects.filter(author=id),
        'another': Books.objects.exclude(author=id)
    }
    request.session['authorind'] = id
    return render(request, 'authorindex.html', context)

def addmoreauthor(request):
    print(request.POST)
    moreauthorid = request.POST['nameauthor']
    author = Authors.objects.get(id=moreauthorid)
    author.book.add(Books.objects.get(id=request.session['bookind']))
    return redirect('/')

def addmorebook(request):
    print(request.POST)
    bookid = request.POST['namebook']
    author = Authors.objects.get(id=request.session['authorind'])
    author.book.add(Books.objects.get(id=bookid))
    return redirect('/authors')