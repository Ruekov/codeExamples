""" 
Organization class
"""

class organization():
	""" 
	Organization (Virtual Class). Organizes objects. Maybe in the future are more organizations.
	"""
	_listOfMembers = []
	
	def isMember(self):
		
		pass
			
	def insertMember(self, member):
		
		pass
			
	def updateMember(self, upMember):
		
		pass
			

class organizationMafia(organization):
	""" 
	Class: Organization Type: Mafia Impl: List of Mafia Members
	"""
	
	def __init__(self, mafiaMember):
			
		self._listOfMembers.append(mafiaMember)
		
	def isMember(self, mafiaMember):
		""" 
		Returns True if the Mafia member object is already a member in the organization
		"""
		
		if mafiaMember.getMemberName() in [item.getMemberName() for item in self._listOfMembers]:
			return True
		else:
			return False
		
	def insertMember(self, mafiaMember):
		""" 
		Inserts a Mafia member object in the organization
		"""
		
		if self.isMember(mafiaMember):
			raise NameError('isAlreadyMember') # X Already is a Member	
		else:
			self._listOfMembers.append(mafiaMember)
			return True
			
	def updateMember(self, mafiaMember):
		""" 
		Updates a Mafia member in the organization with a Mafia member object
		"""
		
		for item in enumerate (self._listOfMembers):
			if mafiaMember.getMemberName() == item[1].getMemberName():
				self._listOfMembers[item[0]] = mafiaMember
				return True
		
		raise NameError('isNotMember') # X Is not a Member
			
	def actualMembers(self):
		""" 
		Prints the active Mafia member objects in a hierarchy
		"""
		capo = True
		
		for item in self._listOfMembers:	
			if item.isActive() == True and capo == True:
				print  'Boss: '+item.getMemberName()+'\t'
				capo = False
			elif item.isActive() == True and capo == False:	
				print  '|-Member: '+item.getMemberName()+'\t'
		
		return True
		
				
	def memberArrested(self, mafiaMember):
		""" 
		A Mafia member gets arrested and goes to jail
		"""
		return self.updateMember(mafiaMember.inJail())
		
		
	def memberReleased(self, mafiaMember):
		""" 
		A Mafia member object gets the freedom
		"""
		return self.updateMember(mafiaMember.outJail())
		
	def memberRemoved(self, mafiaMember):
		""" 
		Removes a Mafia member object
		"""
		return self._listOfMembers.remove(mafiaMember)
		
	def highestMember(self, mafiaMember1, mafiaMember2):
		""" 
		Returns the highest in the hierarchy Mafia member object
		"""
	
		for item in enumerate (self._listOfMembers):
			if mafiaMember1.getMemberName() == item[1].getMemberName() and item[1].isActive():
				return mafiaMember1
			if mafiaMember2.getMemberName() == item[1].getMemberName() and item[1].isActive():
				return mafiaMember2
		
		
		
		
