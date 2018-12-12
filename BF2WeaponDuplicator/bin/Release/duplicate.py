
#daftarYgTakBolehDiReplace = ["ObjectTemplate.collisionMesh", "ObjectTemplate.geometry", "ObjectTemplate.setCollisionMesh", "ObjectTemplate.aiTemplate", "ObjectTemplate.animationSystem", "ObjectTemplate.soundFilename", "ObjectTemplate.weaponHud.selectIcon", "objecttemplate.projectiletemplate"]
daftarYgTakBolehDiReplace = ["ObjectTemplate.collisionMesh", "ObjectTemplate.geometry", "ObjectTemplate.setCollisionMesh", "ObjectTemplate.aiTemplate", "ObjectTemplate.animationSystem", "ObjectTemplate.soundFilename", "ObjectTemplate.weaponHud.selectIcon"]

daftarEditAble = ["ObjectTemplate.weaponHud.hudName", "ObjectTemplate.ammo.nrOfMags ", "ObjectTemplate.ammo.magSize ", "ObjectTemplate.ammo.reloadTime ", "ObjectTemplate.detonation.explosionRadius ", "ObjectTemplate.detonation.explosionForce ", "ObjectTemplate.detonation.explosionDamage ", "ObjectTemplate.detonation.timeUntilCanDetonate ", "ObjectTemplate.minDamage ", "ObjectTemplate.damage ", "ObjectTemplate.distToStartLoseDamage ", "ObjectTemplate.distToMinDamage "]


class copas:
	def __init__(self, source):
		f = open(source)
		self.source = f.read().split('\n')
		f.close()
		self.output = ""

		self.tweaker = {}

	def getEditAbleObject(self):
		l = []
		for i in self.source:
			for editable in daftarEditAble:
				if editable.lower() in i.lower():
					l.append(i.split(' '))

		return l

	def getValue(self, bagian, status = ""):
		if status != "":
			for i in self.source:
				if bagian + "." + status in i:
					temp = i.split(" ")
					if temp[0] != 'rem':
						temp1 = i.replace(temp[0] + " ", "")
						return temp1
		else:
			for i in self.source:
				if bagian in i:
					temp = i.split(" ")
					if temp[0] != 'rem':
						temp1 = i.replace(temp[0] + ' ', "")
						return temp1
		return ""

	def setValue(self, bagian, status, value):
		n = 0
		cek = bagian, status
		if status != "":
			for i in self.source:
				if bagian + "." + status in i:
					temp = i.split(" ")
					if temp[0] != 'rem':
						temp1 = temp[0] + " " + value
						self.source[n] = temp1
				n += 1
		else:
			for i in self.source:
				if bagian in i:
					temp = i.split(" ")
					if temp[0] != 'rem':
						temp1 = temp[0] + " " + value
						self.source[n] = temp1
				n += 1
		
	def duplikasi(self, sourcename, outputname):

		output = self.output

		print("starting to duplicate")

		#so = "\n".join(self.source)
		#sl = so.split('\n')
		sl = self.source

		#print(sl)

		ol = []
		#ol.extend(sl)
		n = 0
		for i in sl:
			lower = i.lower()
			itsok = False
			if sourcename.lower() in lower:
				aman = True
				for ygTakBoleh in daftarYgTakBolehDiReplace:
					if ygTakBoleh.lower() in lower:
						aman = False
				if aman:
					itsok = True
			if itsok:
				#ol.append(lower.replace(sourcename.lower(), outputname.lower()))
				command = i.split(' ')
				cIndex = 0
				for kata in command:
					if sourcename.lower() in kata.lower():
						command[cIndex] = kata.lower().replace(sourcename.lower(), outputname.lower())
					cIndex += 1
				ol.append(" ".join(command))
				if "projectiletemplate" in lower:
					cek = ol[len(ol) - 1], sourcename.lower(), lower, sourcename.lower() in lower, itsok, " ".join(command)
					print(cek)
			else:
				ol.append(i)
				pass
			n += 1


		print("writing data to the file...")
		f = open(output, 'w')
		f.write("\n".join(ol))
		f.close()
		print("selesai. :3")
		print("output file is on " + output)

def duplikasi(source, output, sourcename, outputname):
	print(source)
	print(ouput)

	print("starting to duplicate")

	f = open(source)
	so = f.read()
	f.close()

	sl = so.split('\n')

	#print(sl)

	ol = []
	#ol.extend(sl)
	n = 0
	for i in sl:
		lower = i.lower()
		itsok = False
		if sourcename.lower() in lower:
			aman = True
			for ygTakBoleh in daftarYgTakBolehDiReplace:
				if ygTakBoleh.lower() in lower:
					aman = False
			if aman:
				itsok = True
		if itsok:
			#ol.append(lower.replace(sourcename.lower(), outputname.lower()))
			command = i.split(' ')
			cIndex = 0
			for kata in command:
				command[cIndex] = kata.replace(sourcename.lower(), outputname.lower())
				cIndex += 1	
			ol.append(" ".join(command))
		else:
			ol.append(i)
			pass
		n += 1

def createCopas(source):
	return copas(source)


	print("writing data to the file...")
	f = open(ouput, 'w')
	f.write("\n".join(ol))
	f.close()
	print("selesai. :3")
	print("output file is on " + ouput)