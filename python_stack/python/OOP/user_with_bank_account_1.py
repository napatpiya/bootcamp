class User:
	def __init__(self, username, email_address):
		self.name = username
		self.email = email_address
		self.account = BankAccount(0.02, 0)
	
	def make_deposit(self, amount):
		self.account.deposit(amount)
		return self

	def make_withdrawal(self, amount):
		self.account.withdraw(amount)
		return self

	def display_user_balance(self):
		print("Name: " + self.name)
		self.account.display_account_info()
		print("")
		return self

class BankAccount:
	def __init__(self, rate, balance):
		self.int_rate = rate
		self.balance = balance

	def deposit(self, amount):
		self.balance += amount
		return self

	def withdraw(self, amount):
		self.balance -= amount
		return self

	def display_account_info(self):
		TotalBalance = self.yield_interest()
		print(f"Balance: {TotalBalance}, Interest Reate: {self.int_rate}")
		return self

	def yield_interest(self):
		return self.balance + (self.balance * self.int_rate)


napat = User("Napat", "napat@python.com")
napat.display_user_balance()

napat.make_deposit(1000).make_deposit(1500).make_withdrawal(500).display_user_balance()
