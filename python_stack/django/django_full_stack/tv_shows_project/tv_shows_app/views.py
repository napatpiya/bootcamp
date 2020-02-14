from django.shortcuts import render, redirect, HttpResponse
from tv_shows_app.models import TvShows

# Create your views here.
def index(request):
    return redirect("/shows")

def shows(request):
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
    print(request.POST)
    TvShows.objects.create(title=request.POST['title'], network=request.POST['network'], releasedate=request.POST['reldate'], description=request.POST['desc'])
    last = TvShows.objects.last()
    id = last.id
    return redirect(f"/shows/{id}")

def updateshow(request, id):
    print(request.POST)
    show = TvShows.objects.get(id=id)
    show.title = request.POST['title']
    show.network = request.POST['network']
    show.releasedate = request.POST['reldate']
    show.description = request.POST['desc']
    show.save()
    return redirect(f"/shows/{id}")

def destroyshow(request, id):
    show = TvShows.objects.get(id=id)
    show.delete()
    return redirect("/")