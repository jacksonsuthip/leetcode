# AI DeepSeek

class Solution:
    def totalNumbers(self, digits: List[int]) -> int:
        # Filter out even digits that can be used as the last digit
        even_digits = [d for d in digits if d % 2 == 0]
        
        # If there are no even digits, no even numbers can be formed
        if not even_digits:
            return 0
        
        # Use a set to store unique numbers
        unique_numbers = set()
        
        # Iterate over each even digit as the last digit
        for last_digit in even_digits:
            # Create a list of remaining digits
            remaining_digits = digits.copy()
            remaining_digits.remove(last_digit)
            
            # Generate all possible permutations for the first two digits
            for first_digit in remaining_digits:
                if first_digit == 0:
                    continue  # Skip if the first digit is zero
                
                # Remove the first digit from the remaining digits
                second_digits = remaining_digits.copy()
                second_digits.remove(first_digit)
                
                # Iterate over the remaining digits for the second digit
                for second_digit in second_digits:
                    # Form the number and add it to the set
                    number = first_digit * 100 + second_digit * 10 + last_digit
                    unique_numbers.add(number)
        
        return len(unique_numbers)