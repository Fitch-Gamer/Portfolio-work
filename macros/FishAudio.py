import time
import wave
import pyaudio
import numpy as np
import pyautogui
import pydirectinput
from random import Random

def CompareArrRange(RawArr,CompArr,Range):
    i = 0
    for p in RawArr:
        if((1+Range)*p >= CompArr[i] and (1-Range)*p <= CompArr[i]):
            i+=1
        else:
            return False
    return True

def MeanAverage(RawArr):
    tmp = 0
    arrlen = 0
    for i in RawArr:
        tmp += i
        arrlen +=1
    return tmp/arrlen

RelY = 0
RelX = 0
AimRange = 50
rand = Random()

def Recast():
    print("cast!")
    pydirectinput.click(button='right')
    time.sleep(0.25)
    global RelX,RelY,AimRange
    Ychange = rand.randrange(-AimRange-RelY,AimRange-RelY)
    Xchange = rand.randrange(-AimRange-RelX,AimRange-RelX)
    RelY+=Ychange
    RelX+=Xchange
    time.sleep(0.25)
    pydirectinput.moveRel(yOffset=Ychange,xOffset=Xchange,relative=True)
    pydirectinput.click(button='right')
    


RATE    = 48000
CHUNK   = 1000#15000
    
p               =   pyaudio.PyAudio()
BobberSound = []

tmp = wave.open('C:\\Users\\Finley\\Downloads\\FishNote.wav' , 'rb')
RawFrameRate = 48000
#for i in tmp.readframes(tmp.getnframes()):
#    BobberSound.append(i)
for i in range(0,int((tmp.getnframes()/CHUNK))):
    BobberSound.append(MeanAverage(tmp.readframes(CHUNK)))

for i in range(p.get_device_count()):
    print(str(i) + " " + str(p.get_device_info_by_index(i).get('name')))

ChosenDev = int(input("Choose device "))

stream = p.open(format=pyaudio.paInt16, channels=2, rate=RATE, input=True,input_device_index=ChosenDev, frames_per_buffer=CHUNK)

j = 0
max = len(BobberSound)
print(max)
RawTime = 0
TimeSinceLast= time.time()

while(True):
    #player.write(np.fromstring(stream.read(CHUNK),dtype=np.int16),CHUNK)
    #player.write(np.fromstring(BobberSound[j],dtype=np.int16),CHUNK)
    #if(CompareArrRange(np.fromstring(stream.read(CHUNK),dtype=np.int16), (np.fromstring(BobberSound[j],dtype=np.int16)),0.2)):
    
    RawTime = time.time()
    RawAve = MeanAverage(np.frombuffer(stream.read(CHUNK),dtype=np.int16))
    if(TimeSinceLast-time.time() >30.0):
        TimeSinceLast = time.time()
        Recast()
        j=0
    
    
    if( RawAve >= 250):#BobberSound[j]*0.03):
        j+=1
        print(RawAve)
        #print(time.time() - RawTime)
        #print(j)
        if(j==1):#max):
            
            Recast()
            j=0
    else:
        j=0
    
stream.stop_stream()
stream.close()
p.terminate()

