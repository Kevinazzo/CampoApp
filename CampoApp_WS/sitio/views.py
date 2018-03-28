from django.shortcuts import render
from django.shortcuts import *
from rest_framework.response import Response
from rest_framework.decorators import *
from rest_framework.renderers import JSONRenderer
from MySQLdb.connections import Connection
from MySQLdb.cursors import *
from . import ORM as rr


 
# Create your views here.

cnx = Connection(user='root', password='1234', host='localhost', database='campApp')
cur = cnx.cursor(DictCursor)

@api_view(['GET'])
@renderer_classes((JSONRenderer,))
def getSitio(request, _type,format=None):
	cur.execute("select * from site where tag ="+_type.__str__()+";")
	data= cur.fetchall()
	#metodo viejo usando ORM
#	for item in data:
		#nuevo = rr.sitio(item['id'],item['Name'],item['Description'])
		#result.append(nuevo.__json__())
	return Response(data)