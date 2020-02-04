class User:
	def __init__(self, username, email_address):
		self.name = username
		self.email = email_address
		self.account_balance = 0
	
	def make_deposit(self, amount):
		self.account_balance += amount
		return self

	def make_withdrawal(self, amount):
		self.account_balance -= amount
		return self

	def display_user_balance(self):
		print(f"user: {self.name}, Balance: {self.account_balance}")
		return self

	def transfer_money(self, other_user, amount):
		other_user.make_deposit(amount)
		self.account_balance -= amount
		print(f"Transfer money from {self.name} to {other_user.name} ({amount})")
		print(f"user: {self.name}, Balance: {self.account_balance}")
		print(f"user: {other_user.name}, Balance: {other_user.account_balance}")
		return self
		

napat = User("Napat", "napat@python.com")
tom = User("Tom", "tom@python.com")
andrew = User("Andrew", "andrew@python.com")

napat.make_deposit(100).make_deposit(100).make_deposit(200).make_deposit(300).make_withdrawal(100).display_user_balance()
# napat.make_deposit(100)
# napat.make_deposit(200)
# napat.make_deposit(300)
# napat.make_withdrawal(100)
# napat.display_user_balance()

tom.make_deposit(500).make_deposit(500).make_deposit(600).make_withdrawal(50).make_withdrawal(100).display_user_balance()
# tom.make_deposit(500)
# tom.make_deposit(600)
# tom.make_withdrawal(50)
# tom.make_withdrawal(100)
# tom.display_user_balance()

andrew.make_deposit(2000).make_withdrawal(100).make_withdrawal(200).make_withdrawal(500).display_user_balance()
# andrew.make_deposit(2000)
# andrew.make_withdrawal(100)
# andrew.make_withdrawal(200)
# andrew.make_withdrawal(500)
# andrew.display_user_balance()

print("")

napat.transfer_money(andrew, 400)



