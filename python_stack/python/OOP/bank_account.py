class BankAccount:
	def __init__(self, name, balance):
		self.int_rate = 0.01
		self.account_name = name
		self.balance = balance

	def deposit(self, amount):
		self.balance += amount
		self.yield_interest()
		return self

	def withdraw(self, amount):
		self.balance -= amount
		self.yield_interest()
		return self

	def display_account_info(self):
		TotalBalance = self.yield_interest()
		print(f"Account Name: {self.account_name}, Balance: {TotalBalance}, Interest Reate: {self.int_rate}")
		return self

	def yield_interest(self):
		return self.balance + (self.balance * self.int_rate)

napat = BankAccount("napat", 500)
tom = BankAccount("tom", 2000)

napat.deposit(100).deposit(100).deposit(300).withdraw(100).display_account_info()
tom.deposit(1000).deposit(3300).withdraw(100).withdraw(50).display_account_info()

