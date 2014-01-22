#!/usr/bin/env python

import member
import organization	

def main():
	
	###################################
	#			TEST STORY			  #
	###################################
	
	member0 = member.mafia('Silvio Burlasconi')
	member1 = member.mafia('Vito Coreleone')
	member2 = member.mafia('Luigi Plumberi')
	member3 = member.mafia('Mario Plumberi')
	
	LuigisOrg = organization.organizationMafia(member0)
	LuigisOrg.insertMember(member1)
	LuigisOrg.insertMember(member2)
	LuigisOrg.insertMember(member3)
	
	print '_________LIST OF ACTIVE MEMBERS'
	
	LuigisOrg.actualMembers()
	
	print '_________FBI WORKS HARD_____'+member0.getMemberName()+'_____WENT TO JAIL'

	LuigisOrg.memberArrested(member0)

	print '_________LIST OF ACTIVE MEMBERS'
	
	LuigisOrg.actualMembers()
	
	print '_________LAWYERS WORK HARDER_____'+member0.getMemberName()+'_____IS NOW FREE'

	LuigisOrg.memberReleased(member0)
	
	print '_________LIST OF ACTIVE MEMBERS'
	
	LuigisOrg.actualMembers()
	
	print '_________FBI WORKS HARD_____'+member2.getMemberName()+'_____WENT TO JAIL'

	LuigisOrg.memberArrested(member2)

	print '_________LIST OF ACTIVE MEMBERS'
	
	LuigisOrg.actualMembers()
	
	print '_________LAWYERS WORK HARDER_____'+member2.getMemberName()+'_____IS NOW FREE'

	LuigisOrg.memberReleased(member2)
	
	print '_________LIST OF ACTIVE MEMBERS'	
	
	LuigisOrg.actualMembers()
	
	print '_________SUCCESSFUL CAMPING FOR QUESTING FOR NEW PEOPLE'
	
	memberNames = ['Michelangelo Turtle','Donatello Turtle','Raphel Turtle','Leonardo Turle']
	
	for item in memberNames:
		LuigisOrg.insertMember(member.mafia(item))

	print '_________LIST OF ACTIVE MEMBERS'	
		
	LuigisOrg.actualMembers()
	
	print '________MUSHROOMS ARE BAD_____'+member2.getMemberName()+'_____IS DEAD'

	LuigisOrg.memberRemoved(member2)
	
	print '_________LIST OF ACTIVE MEMBERS'	
		
	LuigisOrg.actualMembers()
	
	print '_________FBI WORKS HARD_____'+member1.getMemberName()+'_____WENT TO JAIL'

	LuigisOrg.memberArrested(member1)

	print '_________LIST OF ACTIVE MEMBERS'
	
	LuigisOrg.actualMembers()
	
	print '_________LAWYERS WORK HARDER_____'+member1.getMemberName()+'_____IS NOW FREE'

	LuigisOrg.memberReleased(member1)
	
	print '_________LIST OF ACTIVE MEMBERS'
	
	LuigisOrg.actualMembers()
	
	print '_________FBI WORKS HARD_____'+member0.getMemberName()+'_____WENT TO JAIL'

	LuigisOrg.memberArrested(member0)
	
	print 'Actual Boss:'+LuigisOrg.highestMember(member1,member0).getMemberName()
	
	print 'Actual Boss:'+LuigisOrg.highestMember(member0,member1).getMemberName()
	
	print '_________LAWYERS WORK HARDER_____'+member0.getMemberName()+'_____IS NOW FREE'

	LuigisOrg.memberReleased(member0)
	
	print 'Actual Boss:'+LuigisOrg.highestMember(member0,member1).getMemberName()
	
	print 'Actual Boss:'+LuigisOrg.highestMember(member1,member0).getMemberName()
	
	return 0

if __name__ == '__main__':
	main()

