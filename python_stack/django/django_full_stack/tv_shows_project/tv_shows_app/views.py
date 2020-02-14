from django.shortcuts import render, redirect, HttpResponse
from tv_shows_app.models import TvShows
from django.contrib import messages

# Create your views here.
def index(request):
    return redirect("/shows")

def shows(request):
    request.session['title'] = ''
    request.session['network'] = ''
    request.session['reldate'] = ''
    request.session['desc'] = ''
    context = {
        'show': TvShows.objects.all()
    }
    return render(request, "allshows.html", context)

def addnew(request):
    return render(request, "addnew.html")

def showinfo(request, id):
    context = {
        'showid': id,
        'show': TvShows.objects.get(id=id)
    }
    return render(request, "showinfo.html", context)

def editshow(request, id):
    context = {
        'showid': id,
        'show': TvShows.objects.get(id=id)
    }
    return render(request, "updateshow.html", context)

def createshow(request):
    #print(request.POST)
    request.session['check'] = 0
    for name in TvShows.objects.all():
        if request.POST['title'] == name.title:
            request.session['check'] = 1
    errors= TvShows.objects.validator(request.POST, request)
    request.session['title'] = request.POST['title']
    request.session['network'] = request.POST['network']
    request.session['reldate'] = request.POST['reldate']
    request.session['desc'] = request.POST['desc']
    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value)
        return redirect("/shows/new")
    else:
        TvShows.objects.create(title=request.POST['title'], network=request.POST['network'], releasedate=request.POST['reldate'], description=request.POST['desc'])
        last = TvShows.objects.last()
        id = last.id
        messages.success(request, "")
        return redirect(f"/shows/{id}")

def updateshow(request, id):
    #print(request.POST)
    request.session['check'] = 0
    oldtitle = TvShows.objects.get(id=id)
    if request.POST['title'] != oldtitle.title:
        for name in TvShows.objects.all():
            if request.POST['title'] == name.title:
                request.session['check'] = 1
    errors= TvShows.objects.validator(request.POST, request)
    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value)
        return redirect(f"/shows/{id}/edit")
    else:
        show = TvShows.objects.get(id=id)
        show.title = request.POST['title']
        show.network = request.POST['network']
        show.releasedate = request.POST['reldate']
        show.description = request.POST['desc']
        show.save()
        messages.success(request, "")
        return redirect(f"/shows/{id}")

def destroyshow(request, id):
    show = TvShows.objects.get(id=id)
    show.delete()
    return redirect("/")