import sys

#   Here we load the variables that have been passed from
#   the C# program.  Note that arg {0} in c# corresponds to
#   argv[1] in python.

a = float(sys.argv[1])
b = float(sys.argv[2])

print(a*b)

