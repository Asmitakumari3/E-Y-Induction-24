import pandas as pd
import matplotlib.pyplot as plt
import numpy as n

# mydataset = {
#   'cars': ["BMW", "Volvo", "Ford"],
#   'passings': [3, 7, 2]
# }

# myvar1 = pd.DataFrame(mydataset)

# print(myvar1)

# print(pd.__version__);
# print(n.__version__);

# a = [1, 7, 2];
# myvar2 = pd.Series(a)

# print(myvar2);


# calories = {"day1": 420, "day2": 380, "day3": 390}

# myvar = pd.Series(calories)

# print(myvar)


# myFile = pd.read_json('C:\\Users\\nikhi\\OneDrive\\Desktop\\EY 24\\E-Y-Induction-24\\Day 13\\posts.json');

# print(myFile);


myData = pd.read_csv('data.csv');

# myData.plot();
myData["Duration"].plot(kind = 'hist')
plt.show();













