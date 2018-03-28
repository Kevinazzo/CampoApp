class sitio:
	def __init__(self,_id,_nombre,_direccion):
		self.id=_id
		self.nombre=_nombre
		self.direccion = _direccion

	def __json__(self):
		json = {"id" : self.id,"nombre" : self.nombre, "direccion" : self.direccion}
		return json