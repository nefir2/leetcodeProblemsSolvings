#!/bin/bash
echo -e "\n\n\t$0\n\n";

echo "searching dotnet on this device . . . ";
command -v dotnet;
if [[ $? -eq 0 ]]; then
	echo "dotnet found.";
else
	echo "dotnet not found. install dotnet before using this script.";
	exit 3;
fi

function fetchNewName() {
	for file in `ls`; do
		if [ "$file" = "$1" ]; then
			echo "current directory already contains $1.";
			return 1;
		fi
	done
	return 0;
}

function help() {
	echo -e "usage: $0 [-h|--help]|[projName]*";
	echo -e "\tprojName - names of new projects.";
	return 0;
}

function readName() {
	echo -n "set name for new proj: ";
	export outp="";
	read outp;
	return $outp;
}

function generateProjectDir() {
	if [ ! -n "$1" ]; then # '-n' if arg is empty
		echo "new projects name is empty.";
		exit 2;
	fi

	export startDir=`pwd`;
	echo "generating project $1 . . . ";
	export proj="${1}Proj";
	export tests="${1}Tests";
	mkdir $1;
	cd $1;
	mkdir 'cs';
	cd 'cs';
	mkdir $proj;
	mkdir $tests;
	cd $proj;
	dotnet new classlib;
	cd ../$tests;
	dotnet new xunit;
	dotnet add reference ../$proj/;

	cd $startDir;

	return 0;
}

if [[ $# -eq 0 ]]; then
	readName;
	export newName=$?;
	generateProjectDir $newName;
elif [[ $# -eq 1 ]]; then
	if [ "$1" = "-h" ] || [ "$1" = "--help" ]; then
		help;
		exit 0;
	fi
	fetchNewName $1;
	if [[ $? -ne 0 ]]; then
		exit $?;
	fi
	generateProjectDir $1;
elif [[ $# -gt 1 ]]; then
	for arg in $@; do
		fetchNewName $arg;
		if [[ $? -ne 0 ]]; then
			echo "skipping . . . ";
			continue;
		fi
		generateProjectDir $arg;
	done;
	exit 0;
fi

exit 0;