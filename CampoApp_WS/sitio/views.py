from django.shortcuts import render
from django.shortcuts import *
from rest_framework.response import Response
from rest_framework.decorators import *
from rest_framework.renderers import JSONRenderer
from MySQLdb.connections import Connection
from MySQLdb.cursors import *
from . import ORM as rr


 
# Create your views here
cnx = Connection(port=3307,user='user16', password='123456', host='mysql8.db4free.net', database='campapp')
cur = cnx.cursor(DictCursor)

@api_view(['GET'])
@renderer_classes((JSONRenderer,))
def getSitio(request, _type,_index,format=None):
	cur.execute("select * from site where tag ="+_type.__str__()+" LIMIT "+(_index*15).__str__()+", 15;")
	data= cur.fetchall()
	#metodo viejo usando ORM
#	for item in data:
		#nuevo = rr.sitio(item['id'],item['Name'],item['Description'])
		#result.append(nuevo.__json__())
	return Response(data)