from django.shortcuts import render, redirect
from .models import Order, Product

def index(request):
    context = {
        "all_products": Product.objects.all()
    }
    return render(request, "store/index.html", context)

def checkout(request):
    order = Order.objects.all()
    product = Order.objects.last()
    total_qtt = 0
    total_price = 0.00
    for name in order:
        total_qtt += name.quantity_ordered
        total_price += float(name.total_price)
    total_price = format(total_price, '.2f')
    context = {
        'orders': order,
        'products': product,
        'qtt': total_qtt,
        'total': total_price
    }
    return render(request, "store/checkout.html", context)

def calc(request):
    print(request.POST)
    quantity_from_form = int(request.POST["quantity"])
    price_from_db = Product.objects.get(id=int(request.POST['product_id']))
    price_is = price_from_db.price
    totle_charge = quantity_from_form * price_is
    Order.objects.create(quantity_ordered=quantity_from_form, total_price=totle_charge)
    print("Charging credit card...")
    return redirect("/checkout")

def reset(request):
    Order.objects.all().delete()
    return redirect("/")