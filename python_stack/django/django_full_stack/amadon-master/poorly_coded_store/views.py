from django.shortcuts import render, redirect
from .models import Order, Product

def index(request):
    request.session['qtt'] = 0
    request.session['sum'] = 0.0
    context = {
        "all_products": Product.objects.all()
    }
    return render(request, "store/index.html", context)

def checkout(request):
    context = {
        'total': request.session['total'],
        'qtt': request.session['qtt'],
        'sum': request.session['sum']
    }
    return render(request, "store/checkout.html", context)

def calc(request):
    print(request.POST)
    quantity_from_form = int(request.POST["quantity"])
    #price_from_form = float(request.POST["price"])
    price_from_db = Product.objects.get(id=request.POST['product_id'])
    price_is = price_from_db.price
    #total_charge = quantity_from_form * price_from_form
    totle_charge = quantity_from_form * price_is
    #request.session['total'] = total_charge
    #request.session['qtt'] += int(request.POST["quantity"])
    #request.session['sum'] += total_charge
    print("Charging credit card...")
    #Order.objects.create(quantity_ordered=quantity_from_form, total_price=total_charge)
    return redirect("/checkout")