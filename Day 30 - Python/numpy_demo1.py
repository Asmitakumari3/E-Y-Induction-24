import numpy as n



a = n.array([1,2,3,4,5,6,7,8,9,10]);
# print(a);
# print(a.ndim);


b = n.array([[1,2,3],[7,8,9],[4,5,6],[12,13,14]]);
print(b.ndim);


c = n.array([2,3,4], ndmin= 5);
# print(c.ndim);

arr = n.array([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12]);
newarr = arr.reshape(4,3);
# print(newarr);




favNumbers = n.array([54,234,45,56,54,4,4326,7,65,76,74,74,32,513,64,754,352,543,6,47,425,34654,754,634,676,742,6364]);
print(n.sort(favNumbers));








