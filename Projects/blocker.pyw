import time
from datetime import datetime as dt



root_path = "hosts.txt"
hosts_path = r"C:\Windows\System32\drivers\etc"
websites = ["www.facebook.com", "www.google.com", "www.test.com"]
redirect = "127.0.0.1"




while True:
    if dt(dt.now().year,dt.now().month, dt.now().day,12) < dt.now() < dt(dt.now().year, dt.now().month, dt.now().day, 19):
      print("Working zhours...")
      with open(hosts_path,"r+") as file:
        content = file.read()
        for website in websites:
          if website in content:
            pass
          else:
            file.write(redirect + " "+ website+ "\n")  
        
    else:

      with open(hosts_path,'r+') as file:
        content = file.readlines()
        file.seek(0)
        for line in content:
          if not any(website in line for website in websites):
            file.write(line)
        file.truncate()

      print("Fun hours...")
      time.sleep(5)