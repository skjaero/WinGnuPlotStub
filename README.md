Windows GnuPlot Stub
====================

What it does: (please READ BEFORE using)
-------------

When working with a lot of test-data, it is sometimes usefull to quickly 
inspect a data plot file, for example when the data is frequently renewed 
or refreshed. 

Double clicking a .plot script file sends the script to gnuplot, however
if the .plot script does not hardcode the location of the data, the .plot
will fail to plot the correct data. This becomes really annoying When 
there are lots of data directories, so that .plot files have to be 
updated in order to .plot the correct data.

This wrapper application captures the directory of the initiating .plot 
script and writes a "cd <directory>" command into the gnuplot.ini file 
in the %APPDATA% folder. So be careful, if you have a custom gnuplot.ini
file, please make a backup first. 

Apart from write-access to the gnuplot.ini file, the only additional 
'requirement' is that gnuplot.exe must be renamed to gnuplot-stubbed.exe, 
and that the supplied exe is put in it's place, as is explained in the 
installation guidelines below.


How to install:
---------------

0) Go to %APPDATA% directory and backup whatever gnuplot.ini file you have.

1) Find your gnuplot.exe in it's <installation path>
   (usually this is C:\Program Files (x86)\gnuplot)

2) Rename gnuplot.exe to gnuplot-stubbed.exe (yes, all lower-case)

3) Build the release version of the project, and find gnuplot-stub.exe
   (you should find a gnuplot-stub.exe under WinGnuPlotStub\bin\Release)

4) Copy gnuplot-stub.exe to <installation path>, rename it to gnuplot.exe

5) Done.



How to use:
-----------

Double click a .plot file, and if Windows asks what it should use to 
open it, pick gnuplot.exe.

In your .plot file, you can directly reference all data files with 
relative paths to the directory the .plot file resides in. No more 
hardcoding cd <path>'s in your plot scripts.


Note:
-----

I quickly threw this together because I needed something like this, and 
searching for it did not yield the desired results. It's not perfect.
If you use it and think it is great, or think it sucks, or if you are 
using a better alternative, have suggestions on how to improve or if you 
experience problems, feel free to let me know. Google-ing my name will 
probably throw an obvious contact email address at you. 

That said, I'm a busy guy so don't expect miracles. Also, you are using 
this entirely at your own risk.


Cheers,
(c) 2014, Ignace Saenen
