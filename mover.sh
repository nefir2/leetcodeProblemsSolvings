#!/bin/bash

export newFolder='cs';
for dir in `ls`; do
	if [ -d $dir ]; then
		export startdir=`pwd`;
		cd $dir;
		mkdir $newFolder;
		for file in `ls`; do
			if [[ "$file" != "$newFolder" ]]; then
				mv $file $newFolder;
			fi;
		done;
		cd $startdir;
	fi;
done;
