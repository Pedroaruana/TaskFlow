import { Pressable, StyleSheet } from 'react-native';

import { ThemedText } from '@/components/themed-text';
import { Spacing } from '@/constants/theme';
import { useTheme } from '@/hooks/use-theme';

type AuthButtonProps = {
  title: string;
  onPress?: () => void;
};

export function AuthButton({ title, onPress }: AuthButtonProps) {
  const theme = useTheme();

  return (
    <Pressable
      onPress={onPress}
      style={({ pressed }) => [
        styles.button,
        { backgroundColor: theme.brandPrimary, opacity: pressed ? 0.85 : 1 },
      ]}>
      <ThemedText style={{ color: theme.brandPrimaryForeground }} type="smallBold">
        {title}
      </ThemedText>
    </Pressable>
  );
}

const styles = StyleSheet.create({
  button: {
    height: 44,
    borderRadius: Spacing.two,
    alignItems: 'center',
    justifyContent: 'center',
  },
});
