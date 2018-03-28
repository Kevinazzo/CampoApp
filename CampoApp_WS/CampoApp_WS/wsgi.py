"""
WSGI config for CampoApp_WS project.

It exposes the WSGI callable as a module-level variable named ``application``.

For more information on this file, see
https://docs.djangoproject.com/en/2.0/howto/deployment/wsgi/
"""

import os
from MySQLdb.connections import Connection
from MySQLdb.cursors import *

from django.core.wsgi import get_wsgi_application

os.environ.setdefault("DJANGO_SETTINGS_MODULE", "CampoApp_WS.settings")

application = get_wsgi_application()

#cnx = Connection(user='root', password='1234', host='localhost', database='campApp')
#db = cnx.cursor(DictCursor)
