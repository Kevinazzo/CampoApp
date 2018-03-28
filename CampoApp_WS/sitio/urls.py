from django.contrib import admin
from django.urls import include, path
import sitio.views as sitioviews


urlpatterns = [
	#path(r'/sitio^(?P<ido>\d+)$', sitioviews.getSitio) #traer sitios por id
   #re_path(r'sitio^(?P<ID>\d+)/$',sitioviews.getSitio),
   path('<int:_type>',sitioviews.getSitio),
   path('<str:_type>/cur=<int:_index>',sitioviews.getSitio)
]