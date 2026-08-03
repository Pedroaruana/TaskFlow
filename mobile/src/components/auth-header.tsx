import { Image } from 'expo-image';
import { StyleSheet, View } from 'react-native';

import { ThemedText } from '@/components/themed-text';
import { Spacing } from '@/constants/theme';

export function AuthHeader() {
  return (
    <View style={styles.row}>
      <Image style={styles.logo} source={require('@/assets/images/taskflow-logo.png')} />
      <ThemedText type="smallBold">TaskFlow</ThemedText>
    </View>
  );
}

const styles = StyleSheet.create({
  row: {
    flexDirection: 'row',
    alignItems: 'center',
    gap: Spacing.two,
    marginBottom: Spacing.four,
  },
  logo: {
    width: 28,
    height: 28,
  },
});
