from django.shortcuts import render, redirect, HttpResponse

def index(request):
    # return HttpResponse("random word app index function")
    return render(request, 'random.html')
