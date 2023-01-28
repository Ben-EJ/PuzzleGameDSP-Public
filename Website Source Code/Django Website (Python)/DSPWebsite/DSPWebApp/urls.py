from unicodedata import name
from xml.etree.ElementInclude import include
from django.urls import URLPattern, path

from . import views
from .views import RestApi8Queens
from .views import RestApi2048
urlpatterns = [
    path('', views.index, name='home'),
    path('eightQueensLeader/', views.eightQueensLeader, name='eightQueensLeader'),
    path('2048Leader/', views.leaderBoard2048, name='2048Leader'),
    path('aboutPage/', views.aboutPage, name='aboutPage'),
    path('rest8QueensPost/', RestApi8Queens.as_view()),
    path('rest2048Post/', RestApi2048.as_view()),
]
