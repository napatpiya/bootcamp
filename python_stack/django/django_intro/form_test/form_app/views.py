from django.shortcuts import render, redirect

def index(request):
    return render(request, "index.html")

def create_user(request):
    print(request.POST)
    print(request.POST.get('gender'))
    request.session['name'] = request.POST['name']
    request.session['email'] = request.POST['email']
    request.session['password'] = request.POST['password']
    if request.POST['gender'] == 'male':
        request.session['gender'] = 'Male'
    elif request.POST['gender'] == 'female':
        request.session['gender'] = 'Female'
    else:
        request.session['gender'] = ''
    # context = {
    #     'name_on_template': name_from_form,
    #     'email_on_template': email_from_form,
    #     'password_on_template': password_from_form,
    #     'gender_on_template': gender_from_form
    # }
    return redirect('/success')

def success(request):
    context = {
        'name_on_template': request.session['name'],
        'email_on_template': request.session['email'],
        'password_on_template': request.session['password'],
        'gender_on_template': request.session['gender']
    }
    return render(request, 'show.html', context)
