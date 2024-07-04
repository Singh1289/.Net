echo "enter numbers :"
read a
b=`expr $a % 2`

if [ $b -eq 0 ]
then
	echo "number is EVEN"
else
	echo "number is ODD" 
fi
