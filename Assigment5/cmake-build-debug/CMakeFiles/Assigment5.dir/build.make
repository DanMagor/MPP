# CMAKE generated file: DO NOT EDIT!
# Generated by "MinGW Makefiles" Generator, CMake Version 3.8

# Delete rule output on recipe failure.
.DELETE_ON_ERROR:


#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:


# Remove some rules from gmake that .SUFFIXES does not remove.
SUFFIXES =

.SUFFIXES: .hpux_make_needs_suffix_list


# Suppress display of executed commands.
$(VERBOSE).SILENT:


# A target that is always out of date.
cmake_force:

.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

SHELL = cmd.exe

# The CMake executable.
CMAKE_COMMAND = "E:\Soft\CLion 2017.2.2\bin\cmake\bin\cmake.exe"

# The command to remove a file.
RM = "E:\Soft\CLion 2017.2.2\bin\cmake\bin\cmake.exe" -E remove -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = "E:\Anton\Study\2nd Year\Fall\MPP\Assigment5"

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = "E:\Anton\Study\2nd Year\Fall\MPP\Assigment5\cmake-build-debug"

# Include any dependencies generated for this target.
include CMakeFiles/Assigment5.dir/depend.make

# Include the progress variables for this target.
include CMakeFiles/Assigment5.dir/progress.make

# Include the compile flags for this target's objects.
include CMakeFiles/Assigment5.dir/flags.make

CMakeFiles/Assigment5.dir/main.cpp.obj: CMakeFiles/Assigment5.dir/flags.make
CMakeFiles/Assigment5.dir/main.cpp.obj: ../main.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir="E:\Anton\Study\2nd Year\Fall\MPP\Assigment5\cmake-build-debug\CMakeFiles" --progress-num=$(CMAKE_PROGRESS_1) "Building CXX object CMakeFiles/Assigment5.dir/main.cpp.obj"
	C:\MinGWx64\bin\g++.exe  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles\Assigment5.dir\main.cpp.obj -c "E:\Anton\Study\2nd Year\Fall\MPP\Assigment5\main.cpp"

CMakeFiles/Assigment5.dir/main.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/Assigment5.dir/main.cpp.i"
	C:\MinGWx64\bin\g++.exe $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E "E:\Anton\Study\2nd Year\Fall\MPP\Assigment5\main.cpp" > CMakeFiles\Assigment5.dir\main.cpp.i

CMakeFiles/Assigment5.dir/main.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/Assigment5.dir/main.cpp.s"
	C:\MinGWx64\bin\g++.exe $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S "E:\Anton\Study\2nd Year\Fall\MPP\Assigment5\main.cpp" -o CMakeFiles\Assigment5.dir\main.cpp.s

CMakeFiles/Assigment5.dir/main.cpp.obj.requires:

.PHONY : CMakeFiles/Assigment5.dir/main.cpp.obj.requires

CMakeFiles/Assigment5.dir/main.cpp.obj.provides: CMakeFiles/Assigment5.dir/main.cpp.obj.requires
	$(MAKE) -f CMakeFiles\Assigment5.dir\build.make CMakeFiles/Assigment5.dir/main.cpp.obj.provides.build
.PHONY : CMakeFiles/Assigment5.dir/main.cpp.obj.provides

CMakeFiles/Assigment5.dir/main.cpp.obj.provides.build: CMakeFiles/Assigment5.dir/main.cpp.obj


# Object files for target Assigment5
Assigment5_OBJECTS = \
"CMakeFiles/Assigment5.dir/main.cpp.obj"

# External object files for target Assigment5
Assigment5_EXTERNAL_OBJECTS =

Assigment5.exe: CMakeFiles/Assigment5.dir/main.cpp.obj
Assigment5.exe: CMakeFiles/Assigment5.dir/build.make
Assigment5.exe: CMakeFiles/Assigment5.dir/linklibs.rsp
Assigment5.exe: CMakeFiles/Assigment5.dir/objects1.rsp
Assigment5.exe: CMakeFiles/Assigment5.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir="E:\Anton\Study\2nd Year\Fall\MPP\Assigment5\cmake-build-debug\CMakeFiles" --progress-num=$(CMAKE_PROGRESS_2) "Linking CXX executable Assigment5.exe"
	$(CMAKE_COMMAND) -E cmake_link_script CMakeFiles\Assigment5.dir\link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
CMakeFiles/Assigment5.dir/build: Assigment5.exe

.PHONY : CMakeFiles/Assigment5.dir/build

CMakeFiles/Assigment5.dir/requires: CMakeFiles/Assigment5.dir/main.cpp.obj.requires

.PHONY : CMakeFiles/Assigment5.dir/requires

CMakeFiles/Assigment5.dir/clean:
	$(CMAKE_COMMAND) -P CMakeFiles\Assigment5.dir\cmake_clean.cmake
.PHONY : CMakeFiles/Assigment5.dir/clean

CMakeFiles/Assigment5.dir/depend:
	$(CMAKE_COMMAND) -E cmake_depends "MinGW Makefiles" "E:\Anton\Study\2nd Year\Fall\MPP\Assigment5" "E:\Anton\Study\2nd Year\Fall\MPP\Assigment5" "E:\Anton\Study\2nd Year\Fall\MPP\Assigment5\cmake-build-debug" "E:\Anton\Study\2nd Year\Fall\MPP\Assigment5\cmake-build-debug" "E:\Anton\Study\2nd Year\Fall\MPP\Assigment5\cmake-build-debug\CMakeFiles\Assigment5.dir\DependInfo.cmake" --color=$(COLOR)
.PHONY : CMakeFiles/Assigment5.dir/depend
