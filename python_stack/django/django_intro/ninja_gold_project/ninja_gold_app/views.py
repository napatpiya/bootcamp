from django.shortcuts import render, HttpResponse, redirect
from random import randint
from time import gmtime, strftime

def index(request):
    # request.session['num'] = 0
    context = {
        "time": strftime("%Y/%m/%d %H:%M %p", gmtime()),
        # "count":request.session['count']
    }
    # request.session['count'] += 0
    request.session['score'] += 0
    return render(request, 'index.html', context)

def process(request):
    print(request.POST)
    if request.POST['check'] == 'farm':
        # request.session['count'] += 1
        request.session['check'] = 'farm'
        request.session['num'] = randint(10, 20)
        request.session['score'] += request.session['num']
        # request.session['aaa'] += f"Earned a casino and lost {request.session.num} golds... Ouch.. ({time})"
        return redirect("/")
    elif request.POST['check'] == 'cave':
        # request.session['count'] += 1
        request.session['check'] = 'cave'
        request.session['num'] = randint(5, 10)
        request.session['score'] += request.session['num']
        return redirect("/")
    elif request.POST['check'] == 'house':
        # request.session['count'] += 1
        request.session['check'] = 'house'
        request.session['num'] = randint(2, 5)
        request.session['score'] += request.session['num']
        return redirect("/")
    elif request.POST['check'] == 'casino':
        # request.session['count'] += 1
        request.session['check'] = 'casino'
        request.session['num'] = randint(-50, 50)
        request.session['score'] += request.session['num']
        return redirect("/")
    return redirect('/')

def reset(request):
    request.session['score'] = 0
    return redirect('/')