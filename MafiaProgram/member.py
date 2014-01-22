""" 
Member class
"""

class member():
	""" 
	Member (Abstract Class). Models members. The key value is Name (private, use getMemberName function).
	"""
	
	_name = 'NaN'
	
	def __init__(self, name):
		
		self._name = name
	
	def getMemberName(self):
		
		return self._name

class mafia(member):
	""" 
	Mafia member. Models Mafia members. The basic value is Name (from member/class). 
	Adds activeMember bool (private, use isActive, inJail or outJail functions).
	"""
	
	_activeMember = True
		
	def __init__(self, name):
		
		self._name = name
			
	def isActive(self):
		""" 
		Returns mafia member status
		"""
		
		return self._activeMember
	
	def inJail(self):
		""" 
		Gives False to the _activeMember Value
		Returns the updated Mafia member object.
		"""
		
		self._activeMember = False
		
		return self
	
	def outJail(self):
		""" 
		Gives True to the _activeMember Value
		Returns the updated Mafia member object.
		"""
		
		self._activeMember = True
		
		return self


