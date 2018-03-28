from django.shortcuts import render
from django.shortcuts import *
from rest_framework.response import Response
from rest_framework.decorators import *
from rest_framework.renderers import JSONRenderer
from . import ORM as rr
 
# Create your views here.


def wicho(request):
	return HttpResponse('<h1>Pinchewicho</h1>')

def generarUsuario(request):
	return HttpResponse('<h1>PincheKevins</h1>')

@api_view(['GET'])
@renderer_classes((JSONRenderer,))
def getSitio(request,id,format=None):
	objeto = rr.sitio(id,"Pizzahut","Calle #101")
	return Response(objeto.__json__())