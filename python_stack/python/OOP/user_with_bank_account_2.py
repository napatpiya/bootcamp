class User:
	def __init__(self, username, email_address):
		self.name = username
		self.email = email_address
		self.saving = BankAccount(0.05, 0)
		self.checking = BankAccount(0.02, 0)
		self.retirement = BankAccount(0.1, 0)
	
	def make_deposit(self, account, amount):
		if account == 'saving':
			self.saving.deposit(amount)
		elif account == 'checking':
			self.checking.deposit(amount)
		elif account == 'retirement':
			self.retirement.deposit(amount)
		return self

	def make_withdrawal(self, account, amount):
		if account == 'saving':
			self.saving.withdraw(amount)
		elif account == 'checking':
			self.checking.withdraw(amount)
		elif account == 'retirement':
			self.retirement.withdraw(amount)
		return self

	def display_user_balance(self, account):
		if account == 'saving':
			print("Name: " + self.name +", Account: " + 'Saving')
			self.saving.display_account_info()
		elif account == 'checking':
			print("Name: " + self.name +", Account: " + 'Checking')
			self.checking.display_account_info()
		elif account == 'retirement':
			print("Name: " + self.name +", Account: " + 'Retirement')
			self.retirement.display_account_info()
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
		print("")
		return self

	def yield_interest(self):
		return self.balance + (self.balance * self.int_rate)


napat = User("Napat", "napat@python.com")

# Deposit and withdrawal money
napat.make_deposit('saving', 1000).make_deposit('checking', 1500).make_withdrawal('saving', 500)

# Display all account infomation
napat.display_user_balance('saving').display_user_balance('checking').display_user_balance('retirement')

