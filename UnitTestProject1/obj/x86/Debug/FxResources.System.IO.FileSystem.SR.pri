mrm_pri2   �#      �    ��    [mrm_decn_info]             X   [mrm_pridescex]         X   H   [mrm_hschemaex]         �   `  [mrm_res_map2_]            p  [mrm_dataitem]          p  x  [mrm_decn_info]         X                                               ����X   [mrm_pridescex]         H        ��                    ����H   [mrm_hschemaex]         `       / $   [def_hnamesx]          ���*   >   m s - a p p x : / / F x R e s o u r c e s . S y s t e m . I O . F i l e S y s t e m . S R /   F x R e s o u r c e s . S y s t e m . I O . F i l e S y s t e m . S R     ]   @      >       `
  �               # F #0   7 A  �8  9 A  �   5 A  &  ; A    G A # T  K A ' �  D A   U)  A A  �9  : A  R  6 A  E   > A  �  J A & p4  : A  L  = A  �5  > A  ;  ; A  �0  6 A  �+  C A  �"  ; A  *'  < A  	  6 A  B(  5 A  �7  8 A  �.  5 A  �  < A  �$  5 A  �  4 A  i  8 A  v*  C I  %    J I & %  K I ' .2  \ I 8 :<  ] I 9   9 I  �-  7 I  �   < I  �   8 I  
  6 I  �,  3 I  
  < I  :  ? I  1  5 I  x  A I  s=  > I  �%  8 I  �  2 I  �  : I  �   > I  z  < I  �!  B I  3  @ I  �  A I  �  7 I  �  6 I  z   E N ! X   A N  �/  A N  �  A N  �   = O  V3  J U & c   D U   �#  4 U  �6        >      8 7 0 $ % ;   & 3 
  1 .  :  5 ( "  + 6 /   4    = 2  >  -       ' #  9  *   <   ?   	 )  ! ,  FxResources.System.IO.FileSystem.SR IndexOutOfRange_IORaceCondition Argument_EmptyPath NotSupported_FileStreamOnNonFiles IO_UnknownFileName IO_SeekAppendOverwrite IO_BindHandleFailed IO_CannotCreateDirectory NotSupported_UnwritableStream ArgumentNull_FileName Arg_FileIsDirectory_Name IO_EOF_ReadBeyondEOF IO_SharingViolation_NoFileName Argument_EmptyFileName Arg_PathIsVolume IO_SetLengthAppendTruncate IO_PathNotFound_Path Arg_Path2IsRooted NotSupported_UnseekableStream Arg_InvalidHandle IO_SourceDestMustHaveSameRoot IO_FileNotFound InvalidOperation_WrongAsyncResultOrEndWriteCalledMultiple ArgumentOutOfRange_FileLengthTooBig IO_FileTooLong2GB IO_SyncOpOnUIThread IO_PathTooLong Argument_InvalidAppendMode ArgumentOutOfRange_NeedNonNegInt32Range IO_SourceDestMustBeDifferent ArgumentOutOfRange_Enum InvalidOperation_EndReadCalledMultiple Argument_InvalidOffLen UnauthorizedAccess_IODenied_NoPathName IO_SharingViolation_File Argument_PathFormatNotSupported UnauthorizedAccess_IODenied_Path Arg_InvalidSearchPattern IO_PathNotFound_NoPathName ArgumentNull_Path Arg_DevicesNotSupported Arg_HandleNotAsync ArgumentOutOfRange_NeedNonNegNum Arg_WrongAsyncResult Argument_PathEmpty IO_FileExists_Name IO_AlreadyExists_Name Arg_InvalidFileAttrs NotSupported_UnreadableStream Argument_InvalidSubPath IO_FileStreamHandlePosition InvalidOperation_EndWriteCalledMultiple ObjectDisposed_FileClosed Argument_InvalidFileModeAndAccessCombo Argument_InvalidPathChars UnknownError_Num Arg_HandleNotSync ArgumentNull_Buffer ArgumentOutOfRange_NeedPosNum IO_FileNotFound_FileName Argument_InvalidSeekOrigin InvalidOperation_WrongAsyncResultOrEndReadCalledMultiple IO_FileTooLongOrHandleNotSync                                            ����`  [mrm_res_map2_]         p                  >   >                                                          >                       	  
                                               !  "  #  $  %  &  '  (  )  *  +  ,  -  .  /  0  1  2  3  4  5  6  7  8  9  :  ;  <  =                                        	    
                                                                                             !    "    #    $    %    &    '    (    )    *    +    ,    -    .    /    0    1    2    3    4    5    6    7    8    9    :    ;    <    =  ����p  [mrm_dataitem]          x          >   L    WX x� @
 L` �1 �1 ! 8 T2 �- �P  ( DQ �) �6 �!   0Z �# �� P9 �m �m l� 8 T= �/ �# �A ,	� �	 �	V 8
* d
$ �
� # 4 Lt �� � �S 3 D dS �, �! @ H� �B @ `9 � � �� � � �  � �� Probable I/O race condition detected while copying memory. The I/O package is not thread safe by default. In multithreaded applications, a stream must be accessed in a thread-safe way, such as a thread-safe wrapper returned by TextReader's or TextWriter's Synchronized methods. This also applies to classes like StreamWriter and StreamReader.  Empty path name is not legal.   FileStream was asked to open a device that was not a file. For support for devices like 'com1:' or 'lpt1:', call CreateFile, then use the FileStream constructors that take an OS handle as an IntPtr.  [Unknown]   Unable seek backward to overwrite data that previously existed in a file opened in Append mode. BindHandle for ThreadPool failed on this handle.    The specified directory '{0}' cannot be created.    Stream does not support writing.    File name cannot be null.   The target file '{0}' is a directory, not a file.   Unable to read beyond the end of the stream.    The process cannot access the file because it is being used by another process. Empty file name is not legal.   Path must not be a drive.   Unable to truncate data that previously existed in a file opened in Append mode.    Could not find a part of the path '{0}'.    Second path fragment must not be a drive or UNC name.   Stream does not support seeking.    Invalid handle. Source and destination path must have identical roots. Move will not work across volumes.   Unable to find the specified file.  Either the IAsyncResult object did not come from the corresponding async method on this type, or EndWrite was called multiple times with the same IAsyncResult. Specified file length was too large for the file system.    The file is too long. This operation is currently limited to supporting files less than 2 gigabytes in size.    Synchronous operations should not be performed on the UI thread.  Consider wrapping this method in Task.Run.    The specified path, file name, or both are too long. The fully qualified file name must be less than 260 characters, and the directory name must be less than 248 characters.   Append access can be requested only in write-only mode. Specified handle value was out of range for the file system.    Source and destination path must be different.  Enum value was out of legal range.  EndRead can only be called once for each asynchronous operation.    Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.  Access to the path is denied.   The process cannot access the file '{0}' because it is being used by another process.   The given path's format is not supported.   Access to the path '{0}' is denied. Search pattern cannot contain '..' to move up directories and can be contained only internally in file/directory names, as in 'a..b'.   Could not find a part of the path.  Path cannot be null.    FileStream will not open Win32 devices such as disk partitions and tape drives. Avoid use of '\\\\.\\' in the path. Handle does not support asynchronous operations. The parameters to the FileStream constructor may need to be changed to indicate that the handle was opened synchronously (that is, it was not opened for overlapped I/O).  Non-negative number required.   IAsyncResult object did not come from the corresponding async method on this type.  Path cannot be the empty string or all whitespace.  The file '{0}' already exists.  Cannot create '{0}' because a file or directory with the same name already exists.  Invalid File or Directory attributes value. Stream does not support reading.    The directory specified, '{0}', is not a subdirectory of '{1}'. The OS handle's position is not what FileStream expected. Do not use a handle simultaneously in one FileStream and in Win32 code or another FileStream. This may cause data loss.   EndWrite can only be called once for each asynchronous operation.   Cannot access a closed file.    Combining FileMode: {0} with FileAccess: {1} is invalid.    Illegal characters in path. Unknown error '{0}'.    Handle does not support synchronous operations. The parameters to the FileStream constructor may need to be changed to indicate that the handle was opened asynchronously (that is, it was opened explicitly for overlapped I/O).   Buffer cannot be null.  Positive number required.   Could not find file '{0}'.  Invalid seek origin.    Either the IAsyncResult object did not come from the corresponding async method on this type, or EndRead was called multiple times with the same IAsyncResult.  IO operation will not work. Most likely the file will become too long or the handle was not opened to support synchronous IO operations.        ����x  ���޸#  mrm_pri2