function [occurance, uniqueChars] = countChars(fileName)

  content = regexprep(fileread(fileName),'[^a-zA-Z]','');
  uniqueChars = unique(content);
  occurance = histc(content, uniqueChars);

end
