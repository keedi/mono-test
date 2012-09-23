CC   = mono-csc
RM   = rm

SRCS = \
	hello-world.cs \
	p16-1.cs \
	p16-2.cs \
	p17.cs \
	p18.cs \
	p19-1.cs \
	p19-2.cs \
	p20.cs \
	p21.cs \
	p22.cs \
	p23.cs \
	p24.cs \
	p26.cs \
	p27.cs \
	p28.cs \
	p29.cs \
	p31.cs \
	p34.cs \
	p35.cs \
	p36.cs \
	p37-1.cs \
	p37-2.cs \
	p38.cs \
	p39.cs \
	p43.cs \
	p45.cs \
	p46.cs \
	p47.cs \
	p48.cs \

OBJS = ${SRCS:.cs=.exe}

# clear out all suffixes
# list only those we use
.SUFFIXES:
.SUFFIXES: .exe .cs

# define a suffix rule for .c -> .o
.cs.exe:
	$(CC) $(CFLAGS) $<

.PHONY: all clean combined objs

# default target by convention is ``all''
all: objs combined

objs: $(OBJS)

combined: p50-1.cs p50-2.cs
	$(CC) /optimize $^ /out:$@.exe
	#mono-csc -target:library /out:p50-1.dll p50-1.cs
	#mono-csc -lib:. -reference:p50-1.dll p50-2.cs /out:p50-2.exe

clean:
	$(RM) -f $(OBJS)
