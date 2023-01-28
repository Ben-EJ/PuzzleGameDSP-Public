from http.client import HTTPResponse
import imp
from operator import truediv
from django.shortcuts import render
from django.http import HttpResponse
from .models import ScoreData2048, ScoreDataPuzzleOne #imports database model
# Create your views here.
# A view function takes a HTTP request and returns a response (Request Handler)

#86.134.228.24:8765
from django.views import View
from django.http import JsonResponse
import json
from django.utils.decorators import method_decorator
from django.views.decorators.csrf import csrf_exempt

"""
For tesing POST request in console:
curl --header "Content-Type: application/json" \ --request POST \ --data '{\"userName\":\"RESTAPITEST\", \"score\":\"5000\"}' \ -url "http://127.0.0.1:8000/index/RestApi/"
"""
# REST API Handles 8 queens post requests. 
@method_decorator(csrf_exempt, name='dispatch')
class RestApi8Queens(View):
    #Handles post requests
    def post(self, request):
        jsonData = json.loads(request.body.decode("utf-8"))
        userNameFromJson = jsonData.get('userName')
        scoreFromJson = jsonData.get('score')
        ScoreDataPuzzleOne(userName=userNameFromJson,score=int(scoreFromJson)).save()
        return JsonResponse(jsonData, status=201)

# REST API Handles 2048 post requests. 
@method_decorator(csrf_exempt, name='dispatch')
class RestApi2048(View):
    #Handles post requests
    def post(self, request):
        jsonData = json.loads(request.body.decode("utf-8"))
        userNameFromJson = jsonData.get('userName')
        scoreFromJson = jsonData.get('score')
        ScoreData2048(userName=userNameFromJson,score=int(scoreFromJson)).save()
        return JsonResponse(jsonData, status=201)

# Function takes user to home page
def index(request):
    return render(request, 'index.html')

# Function takes user to about page
def aboutPage(request):    
    return render(request, 'about.html')

# Function takes user to Eight Queens Leader board page and displays leader board
def eightQueensLeader(request):    
    allRecords = ScoreDataPuzzleOne.objects.all()#gets database table (Database query)
    sortedRecords = sorted(allRecords, key=lambda ScoreDataPuzzleOne:ScoreDataPuzzleOne.score,reverse=True)
    return render(request, 'eightqueensleader.html', {'all_records' : sortedRecords})

# Function takes user to 2048 Leader board page and displays leader board
def leaderBoard2048(request):    
    allRecords = ScoreData2048.objects.all()#gets database table (Database query)
    sortedRecords = sorted(allRecords, key=lambda ScoreData2048:ScoreData2048.score,reverse=True)
    return render(request, '2048Leader.html', {'all_records' : sortedRecords})