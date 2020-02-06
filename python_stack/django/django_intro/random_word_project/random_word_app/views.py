from django.shortcuts import render, redirect, HttpResponse
from django.utils.crypto import get_random_string


def index(request):
    request.session['temp'] += 1
    request.session['random'] = get_random_string(length=14)
    return render(request, 'random.html')

def gen(request):
    return redirect('random_word/')

def reset(request):
    request.session['temp'] = 0
    return redirect('random_word/')

