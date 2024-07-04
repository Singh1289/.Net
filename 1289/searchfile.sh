echo "enter file name :"
read a

if [ -f $a ]
then
	echo "$a : file is found." 
elif [ -d $a ]
then
	echo "$a : is directory."
else
	echo "$a : does not exist."
fi

