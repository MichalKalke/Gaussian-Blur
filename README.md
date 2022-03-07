# Gaussian-Blur

This program is used to apply a Gussian blur to an image.

The algorithm is based on box blur, when it is applied an appropriate number of times produces a blur that is very close to Gaussian's one.

How does it work?
At the begginig, we need to calculate the accumulator value by one-dimensional blur. After that, we insert the value of the leftmost cell into it. When calculating the next values, we edit the previous value at a constant time. One-dimensional blur is applied twice and the field blur is applied three times.

### The user interface:
![gb](https://user-images.githubusercontent.com/56382792/156933212-fed8d1f3-5eba-47e8-8cf1-c6f7190f9e71.png)

First of all, you can choose which DLL will process the Gaussian blur - Asembler or C#.
Secondly, you need to enter a file name with a .bmp extension.
Thirdly, you can choose the power of the blux (out of box it is set to 10) and the number of threads (out of the box it is set to 4).
After the blur is applied, the time in ms is displayed above the blur power.
