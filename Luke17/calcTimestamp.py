import datetime

fromDate = datetime.datetime(year=1814,month=5,day=17,hour=13,minute=37,second=14)
toDate = datetime.datetime(year=2015,month=9,day=17,hour=17,minute=15,second=00)
print (toDate - fromDate).total_seconds()
