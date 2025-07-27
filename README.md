# PointsBet Backend Online Code Test

This .NET Core console application provides functionality for string formatting. It's packaged using Docker for easy deployment and accepts user input through command-line arguments.

---

## Description

> This function formats a string array by enclosing each item in a specified quote character and then joining them with commas. It takes the array of strings and the desired quote character as input, and outputs a single string with each item quoted and comma-separated.

---

## Overview

This project uses C# and the .NET SDK to solve the problem. The application accepts inputs as arguments when the container runs.

> Example:  
> `dotnet run -- Sachin Virat Joe William Steve Shaq`  
> or  
> `docker run pointsbeconsoleapp Sachin Virat Joe William Steve Shaq`

---

## Run with Docker

### 1. **Build the Docker image**
```bash
docker build -t pointsbeconsoleapp .
```
---

### 2. **Run the container with input arguments**
```
docker run puzzle-solver [your-arguments]
```
example:
```
docker run pointsbeconsoleapp Sachin Virat Joe William Steve Shaq
```

---

### **Project Structure**

-> Dockerfile  
-> Program.cs  
-> StringFormatter.cs        # Main logic  
-> README.md   



